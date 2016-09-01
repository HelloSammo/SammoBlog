$(function () {
    var vue = new Vue({
        el: "#categoryList",
        data: {
            categories: [],
            getCategoryUrl: "/Mark/GetAllCategories",
            addCategoryUrl: "/Mark/Add",
            categoryItem:{}
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
            },
            addCategory: function () {
                var vm = this;
                if (!vm.isNameExists())
                    return;

                vm.$http.post(vm.addCategoryUrl, vm.categoryItem).then((response) => {
                    vm.checkResponse(response),
                    vm.$set('categoryItem', {}),
                    vm.getCategories()
                }).catch(function (response) {
                    console.log(response)
                })
            },

            isNameExists: function () {
                if ($('#categoryName').val() == "") {
                    alert('分类名不能为空！');
                    return false;
                }
                return true;
            },

            checkResponse:function(response){
                if(!response.data.Success){
                    alert(response.data.Message);
                    return;
                }
            }
        }
    })
})
