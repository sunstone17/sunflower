<template>
    <div>
        <button v-on:click="count++">You clicked me {{ count }} times.</button>
    </div>
</template>

<script>
export default {
    data(){
        return {
            name:'ButtonCounter',
            count:0
        }
    }
    
}
</script>

<style>

</style>


