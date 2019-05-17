<template>
<div>
    <!-- v-if 有更高的切换开销，而 v-show 有更高的初始渲染开销。
    因此，如果需要非常频繁地切换，则使用 v-show 较好；
    如果在运行时条件很少改变，则使用 v-if 较好。 -->
    <div v-show="isShow">
        <p>v-show test</p>
    </div>
    <button @click="show">{{showValue}}</button>


    <!-- with key -->
    <template v-if="loginType === 'username'">
    <label>Username</label>
    <input placeholder="Enter your username" key="username-input">
    </template>
    <template v-else>
    <label>Email</label>
    <input placeholder="Enter your email address" key="email-input">
    </template>
    <br />
    <button @click="changeLoginType">Toggle login type</button>

    <!-- without key -->
    <template v-if="loginType === 'username'">
    <label>Username</label>
    <input placeholder="Enter your username">
    </template>
    <template v-else>
    <label>Email</label>
    <input placeholder="Enter your email address">
    </template>
    <br />
    <button @click="changeLoginType">Toggle login type</button>
</div>
</template>
<script>
export default {
    name: 'ConditionalRending',
    data() {
        return {
             loginType: 'username',
             showValue: 'hide',
             isShow: true,
        }
    },
    methods:{
        changeLoginType: function(){
            if(this.loginType === 'username')
                this.loginType = 'email'
            else
                this.loginType = 'username'
        },
        show: function(){
            this.isShow = !this.isShow
            this.showValue = this.isShow? 'hide' : 'show'
        }
    }

}
</script>

