var booksServices = angular.module('booksServices', []);

booksServices.factory('crudService', ['$http', function ($http) {
    var factory = {};

    factory.loadBooks = function () {
        factory.books = [];
        $http.get("/bookscatalog/api/books").success(function(data) {
            factory.books = data;
        });

        return factory.books;
    };

    factory.saveBook = function (book) {
        $http.post("/bookscatalog/api/books",
        {
            "name": book.name,
            "authorId": book.authorId,
            "genreId": book.genreId
        });
    };

    return factory;
}]);