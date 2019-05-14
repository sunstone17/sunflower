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
    }
}
</script>
        
