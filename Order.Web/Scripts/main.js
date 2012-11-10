(function () {
    var root = this;

    define3rdPartyModules();
    loadPluginsAndBoot();

    function define3rdPartyModules() {
        define('jquery', [], function () { return root.jQuery; });
        define('ko', [], function () { return root.ko; });
        define('amplify', [], function () { return root.amplify; });
        define('infuser', [], function () { return root.infuser; });
        define('moment', [], function () { return root.moment; });
        define('sammy', [], function () { return root.Sammy; });
        define('toastr', [], function () { return root.toastr; });
        define('underscore', [], function () { return root._; });
    }

    function loadPluginsAndBoot() {
        requirejs([], boot);
    }

    function boot() {
        require(['jquery'], function ($) {
            $('body').html('<p>Hello world! This is HTML5 Boilerplate.</p>');
        });
    }

})();