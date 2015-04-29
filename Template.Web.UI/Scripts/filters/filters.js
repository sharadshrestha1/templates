'use strict';

var filMod = angular.module('app.filters', [])

filMod.filter('interpolate', ['version', function (version) {
        return function (text) {
            return String(text).replace(/\%VERSION\%/mg, version);
        }
    }]);