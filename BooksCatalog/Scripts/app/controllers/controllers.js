var booksController = new angular.module('booksController', []);

booksController.controller('BookListCtrl', ['$scope', '$http', 'crudService',
    function ($scope, $http, crudService) {

        crudService.getBooks(function (data) {
            $scope.books = data;
        });

        crudService.getAuthors(function (data) {
            $scope.authors = data;
        });

        crudService.getGenres(function (data) {
            $scope.genres = data;
        });

        $scope.save = function () {
            crudService.saveBook($scope.newBook);
            $scope.newBook = {};
        };
    }
]);