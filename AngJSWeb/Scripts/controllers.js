'use strict';

// Google Analytics Collection APIs Reference:
// https://developers.google.com/analytics/devguides/collection/analyticsjs/

angular.module('app.controllers', [])

    // Path: /
    .controller('HomeCtrl', ['$scope', '$location', '$window', '$http', function ($scope, $location, $window, $http) {

        $scope.$root.title = 'AngularJS SPA Template for Visual Studio';
        $scope.$on('$viewContentLoaded', function () {
            $window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
        });
    }])
    .controller('ContactCtrl', ['$scope', '$location', '$window', '$http', function ($scope, $location, $window, $http) {

        $scope.$root.title = 'Contacts';


        $scope.getData = function () {

            $http({
                url: '/api/address',
                method: "GET"
            })
                .success(function (data, status, headers, config) {
                    $scope.todoList = data.dto;
                }).error(function (data, status, headers, config) {
                    $scope.message = data.error_description.replace(/["']{1}/gi, "");
                    $scope.showMessage = true;
                });


        }


        $scope.getData();


           
        }])
    // Path: /error/404
    .controller('Error404Ctrl', ['$scope', '$location', '$window', '$http', function ($scope, $location, $window, $http) {
        $scope.$root.title = 'Error 404: Page Not Found';
        $scope.$on('$viewContentLoaded', function () {
            $window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
        });
    }]);