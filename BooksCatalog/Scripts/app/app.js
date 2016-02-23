'use strict';
var booksCatalogApp = new angular.module('booksCatalogApp', [
    'ngRoute',
    'booksController',
    'booksServices',
    'booksFilters'
]);

booksCatalogApp.config(['$routeProvider',
    function($routeProvider) {
        $routeProvider
        .when('/books', {
            templateUrl: 'BooksCatalog/Scripts/app/partials/BooksList.html',
            controller: 'BookListCtrl'
        })
        .when('/new', {
            templateUrl: 'BooksCatalog/Scripts/app/partials/BookEdit.html',
            controller: 'BookEditCtrl'
        })
        .otherwise({
          redirectTo: '/books'
        });
    }
]);