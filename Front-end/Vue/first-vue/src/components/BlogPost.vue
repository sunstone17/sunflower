<template>
    <div class="blog-post">
      <h3>{{ post.title }}</h3>
      <button v-on:click="$emit('enlarge-text', 0.1)">
        Enlarge text
      </button>
    </div>
</template>
<script>
export default {
    data(){
        return{
            
        }
    },
    props:{
      post: Object ,
      },
    inheritAttrs: false,
}
</script>

