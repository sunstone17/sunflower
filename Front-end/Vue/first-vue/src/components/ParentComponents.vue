<template>
    <div>
    <!-- <ButtonCounter></ButtonCounter> -->
    <ButtonCounter size = 110></ButtonCounter>
    <div :style="{fontSize: postFontSize + 'em'}">
         <!-- 监听器 -->
        <BlogPost 
        v-on:enlarge-text="postFontSize += $event"
        v-for="post in posts" 
            :key="post.id"
            :post="post"></BlogPost>
    </div>
    <label> Parent:  </label>
    <input v-model="searchText" placeholder="searchText">

    <CustomerInput v-model="searchText"></CustomerInput>
    </div>
</template>

<script>
import ButtonCounter from './ButtonCounter'
import BlogPost from './BlogPost.vue'
import CustomerInput from './CustomerInput.vue'

export default {
    components:{
        ButtonCounter,
        BlogPost,
        CustomerInput,
    },
    data(){
        return{
            posts:[{
                    title:'My journey with Vue', 
                    id: 1
                    },
                    {
                    title:'Blogging with Vue', 
                    id: 2
                    },
                    {
                    title:'Why Vue is so fun', 
                    id: 3
}
            ],
            postFontSize: 1,
            searchText: 'defalut',
        }
    },
    methods:{
        onEnlargeText: function(size){
            this.postFontSize += size;
        }
    }
}
</script>

<style>

</style>
