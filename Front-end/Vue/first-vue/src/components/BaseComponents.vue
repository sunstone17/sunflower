<template>
    <div>
        <button v-on:click="count++">You clicked me {{ count }} times. </button>
        <span>{{normalizedSize}} is in</span>
    </div>
</template>

<script>
export default {
    data(){
        return {
            name:'buttonCounter',
            count:0
        }
    },
    props: ["size"],
    computed: {
        normalizedSize: function () {
            return this.size.trim().toLowerCase()
  }
}

}
</script>

<style>

</style>
