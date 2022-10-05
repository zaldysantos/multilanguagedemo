function setLayout(lang, dir) {
    if (dir != "ltr" && dir != "rtl") return;
    document.getElementsByTagName("html")[0].dir = dir;
    document.getElementsByTagName("html")[0].lang = lang;
    var isRtl = dir === "rtl";
    var styleSheets = document.styleSheets;
    try {
        for (var i = 0; i < styleSheets.length; i++) {
            var rules = styleSheets[i].cssRules || styleSheets[i].rules;
            if (rules) {
                for (var j = 0; j < rules.length; j++) {
                    if (rules[j].type === 4) {
                        var mediaRules = rules[j].cssRules || rules[j].rules;
                        for (var y = 0; y < mediaRules.length; y++) {
                            setCssRules(mediaRules[y], isRtl);
                        }
                    }
                    if (rules[j].type === 1) {
                        setCssRules(rules[j], isRtl);
                    }
                }
            }
        }
    } catch (err) {
        console.log(err);
    }
}

function setCssRules(rule, isRtl) {
    var toLeft = isRtl ? "left" : "right";
    var toRight = isRtl ? "right" : "left";
    if (rule.style.getPropertyValue(toLeft) && rule.selectorText.match(/\.col-(xs|sm|md|lg)-push-\d\d*/)) {
        rule.style.setProperty(toRight, rule.style.getPropertyValue(toLeft));
        rule.style.removeProperty(toLeft);
    }
    if (rule.style.getPropertyValue(toRight) && rule.selectorText.match(/\.col-(xs|sm|md|lg)-pull-\d\d*/)) {
        rule.style.setProperty(toLeft, rule.style.getPropertyValue(toRight));
        rule.style.removeProperty(toRight);
    }
    if (rule.style.getPropertyValue(isRtl ? "margin-left" : "margin-right") && rule.selectorText.match(/\.col-(xs|sm|md|lg)-offset-\d\d*/)) {
        rule.style.setProperty((isRtl ? "margin-right" : "margin-left"), rule.style.getPropertyValue((isRtl ? "margin-left" : "margin-right")));
        rule.style.removeProperty((isRtl ? "margin-left" : "margin-right"));
    }
    if (rule.style.getPropertyValue("float") && rule.selectorText.match(/\.col-(xs|sm|md|lg)-\d\d*/)) {
        rule.style.setProperty("float", toRight);
    }
}