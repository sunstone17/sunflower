<template>
<div> 
    <h1>
    first vue
    </h1>

    <div id="appA"> 
        {{message}}
    </div>

</div>
</template>

<script>
    export default {
    name: 'appA',
    data() {
        return {
            message: 'hello first-vue'
        }
    },
    beforeCreate: function(){
        console.log('beforeCreate')
    },
    created: function(){
        console.log('created')
    },
    beforeMount: function(){
        console.log('beforeMount')
    },
    mounted: function(){
        console.log('mounted')
    },
    beforeUpdate: function(){
        console.log('beforeUpdate')
    },
    updated:function(){
        console.log('updated')
    },  
    beforeDestroy:function(){
        console.log('beforeDestroy')
    },
    destroyed:function(){
        console.log('destory')
    }
}
</script>
        
