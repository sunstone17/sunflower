<template>
    <div class="static" :class="{active: isActive, 'text-danger' : hasError}">
    <div id="div1" :class='classObj'></div>
    <div id="div2" :class='classObjCpt'></div>
    <div id="div3" :style="{ display: ['-webkit-box', '-ms-flexbox', 'flex'] }"></div>

    </div>

</template>
<script>
export default {
    name:'',
    data() {
        return {
            isActive: true,
            hasError: true,
            classObj: {
                active: true,
                'text-danger': false,
            }
        }
    },
    computed:{
        classObjCpt: function(){
            return {active: this.isActive, 'text-danger': this.hasError}
        }
    }
}
</script>
