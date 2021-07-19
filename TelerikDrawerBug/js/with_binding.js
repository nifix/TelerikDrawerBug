/**
 * Creates observable
 * */
obs = kendo.observable({
    test: "With"
});

/**
 * Adds binding to the content
 * */
function initialize() {
    kendo.bind($("#content"), obs);
}

/**
 * Initializes on the ready event
 * */
$(document).ready(initialize());