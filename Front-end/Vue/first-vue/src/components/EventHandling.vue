<template>
    <div>
        <button @click="counter += 1"> Add 1 </button>
        <P>clicked times: {{counter}}</p>

        <button @click="greet">Greet</button>
        <!-- 内联处理器中的方法 -->
        <button @click="say('Hi', $event)">Say Hi</button>

<!-- 事件修饰符 -->
        <a v-on:click.self.prevent="doThis">aaa</a>

        <a v-on:click.prevent.self="doThis">bbb</a>

        <a v-on:click.once="doThis">once</a>

        <form @submit.prevent="doThis"> submit </form>

        <form @submit="doThis"> normal submit </form>

        <input v-on:keyup.enter="doSubmit" placeholder="Submit">

        <input v-on:keyup.page-down="onPageDown" placeholder="PageDown">

        <input v-on:keyup.esc="esc" placeholder="Esc">
        
        <input v-on:keyup.ctrl.c="noCopy" placeholder="No Copy">

        <input v-on:keyup.right="mouseRight" placeholder="mouse Right">

    </div>

</template>

<script>
export default {
    data(){
        return {
            name:'Vue.js',
            counter: 0,
        }
    },
    methods:{
        greet: function(event){
            alert('Hello ' + this.name + '!')
            if(event){
                alert(event.target.tagName)
            }
        },
        say:function(msg, event){
            alert(msg + ', '    + event.target.tagName)
        },
        doThis:function(){
            alert('Do this')
        },
        doSubmit:function(){
            alert('Do submit')
        },
        onPageDown: function(){
            alert('Do onPageDown')
        },
        esc: function(event){
            event.target.value = ''
        },
        noCopy:function(){
            alert('No copy')
            event.preventDefault()
        },
        mouseRight:function(){
            alert('mouse right')
        }
    }
}
</script>
