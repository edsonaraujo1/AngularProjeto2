var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('AngularProjeto2');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);