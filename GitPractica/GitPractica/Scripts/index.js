

Vue.component('div-peliculas', {

    template: '#templateNoob',
    props: ['listaPeliculas']

});


var vm = new Vue({
    el: "#raiz",
    data: { // se inicializan cuando se crea el componente
        tittle: "Pelicula Pro Numero 1",
        listaPeliculas: {}
    },
    mounted: function () {
        this.CargarPeliculas();
    },
    methods: {
        CargarPeliculas: function () {

            fetch("/Home/ObtenerPeliculas")
                .then(function (response) {
                    return response.json();
                })
                .then(function (json) {
                    this.listaPeliculas = json.ListaPeliculas
                }.bind(this));
        }

    }


});