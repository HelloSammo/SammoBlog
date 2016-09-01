$(function () {
    var vue = new Vue({
        el: "#categoryList",
        data: {
            categories: [],
            getCategoryUrl: "/Mark/GetAllCategories"
        },
        ready: function () {
            this.getCategories()
        },
        methods: {
            getCategories: function () {
                this.$http.get(this.getCategoryUrl).then((response) => {
                    this.$set('categories', response.data)
                }).catch(function (response) {
                    console.log(respoonse)
                })
            }
        }

    })
})