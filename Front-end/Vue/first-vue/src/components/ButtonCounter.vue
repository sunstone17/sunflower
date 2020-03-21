<template>
    <div>
        <button v-on:click="count++">You clicked me {{ count }} times.</button>
        <span>{{size}} is in</span>
    </div>
</template>

<script>
export default {
    data(){
        return {
            name:'ButtonCounter',
            count:0
        }
    },
    props: ["size"],
    computed: {
        normalizedSize: function () {
            return this.size.trim().toLowerCase()
        }
    },
    mounted: function(){
        console.log('mounted' + this.size)
    }
    
}
</script>

<style>

</style>


