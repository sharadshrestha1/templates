'use strict'
var mod = angular.module('app.controllers');

mod.controller('AboutCtrl', ['$scope', '$location', '$window', '$http', function ($scope, $location, $window, $http) {
        $scope.$root.title = 'AngularJS SPA | About';
        $scope.text = 'this is some sample text';
        $scope.address = '';
    $scope.state = '';
        $scope.getData = function () {

            $http({
                url: '/api/address',
                method: "GET"
            })
                .success(function (data, status, headers, config) {
                    $scope.address = data.dto;
                $scope.state = data.dto.state;
            }).error(function (data, status, headers, config) {
                    $scope.message = data.error_description.replace(/["']{1}/gi, "");
                    $scope.showMessage = true;
                });
            

        }


        $scope.getData();

        $scope.$on('$viewContentLoaded', function () {
            $window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
        });
    }])