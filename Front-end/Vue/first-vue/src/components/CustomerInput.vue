<template>
    <div>
        <label>Child: </label>

        <input v-bind:value="value"
            v-on:input="$emit('input', $event.target.value)"
        >
        <label>Child2: </label>

        <input v-model="inputValue"
        >

        <br/>
        <label>input is {{inputValue}}</label>

        <br/>
        <label>computed is {{computedValue}}</label>

    </div>
</template>
<script>
export default {
    data(){
        return{
            inputValue: this.value,
        }
    },
    props:["value"],
    methods:{
        
    },
    computed:{
        computedValue:function(){
             return this.value
        }
    }
}
</script>
