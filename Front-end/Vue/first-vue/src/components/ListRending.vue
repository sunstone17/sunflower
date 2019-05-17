<template>
    <div>
        <button @click="push">push</button>
        <button @click="reverse">reverse</button>
        <button @click="filter">filter</button>
        <button @click="setByIndex">setByIndex</button>
        <button @click="vueSet">Vue.set array</button>
        <button @click="vueSetProperty">vueSetProperty</button>
        <button @click="setProperty">setProperty</button>

        <ul>
            <li v-for="(item, index) in items"  v-bind:key = "item.id">
            {{parent}} - {{item.message}} - {{index}}
            </li>
        </ul>
        <div v-for="(value, name, index) in object" v-bind:key = "index" >
            {{name}} - {{value}} - {{index}}
        </div>

    </div>
</template>

<script>
export default {
    name: 'listRending',
    data() {
        return {
            items: [
                {message: 'Foo'},
                {message: 'Bar'}
            ],
            parent: 'Parent',

            object:{
                name: 'stone',
                age: 29,
                sex: 'male'
            }
        }
    },
    methods:{
        //mutation method
        push: function(){
            this.items.push({message: 'Car'})
        },
        //mutation method
        reverse: function(){
            this.items.reverse()
        },
        //non-mutating method
        filter: function(){
            this.items = this.items.filter(function(item){
                return item.message.match(/Foo/)
            })
        },
        setByIndex: function(){
            this.items[0] = {message: 'desk'};
        },
        vueSet: function(){
            if(this.items[0].message === 'desk')
                this.$set(this.items, 0 , {message: 'Foo'});
            else 
                this.$set(this.items, 0 , {message: 'desk'});
        },
        vueSetProperty: function(){
            let vm = this;
            this.$set(vm.object, 'eye', 'yellow');
        },
        setProperty: function(){
            let vm = this;
            vm.object.height = '179cm'
        }

    }
}
</script>
