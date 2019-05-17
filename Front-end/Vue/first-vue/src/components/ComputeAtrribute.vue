<template>
    <div>
        <p>Original message: "{{ message }}"</p>
        <label> message: </label>
        <input v-model="message"/>
         <br />
        <label> lastName: </label>
        <input v-model="lastName"/>
         <br />
        <label> firstName:  </label>
        <input v-model="firstName"/>

        <!-- <input v-model="message" :disabled = 'enable'/> -->
        <p>Computed reversed message: "{{ reversedMessage }}"</p> 
       
        <p>Computed reversed message: "{{ now }}"</p>
        <p>Full Name: "{{ fullName }}"</p>

    </div>
</template>

<script>
export default {
    data(){
        return {
            message: 'hello',
            // enable: true,
            firstName:'',
            lastName: '',
        }
    },
    created: function(){
        this.fullName = 'stone sun'
    },
    computed:{
        reversedMessage:function(){
            return this.message.split('').reverse().join('')
        },
        now: function(){
            return Date.now()
        },
        fullName: {
            get: function(){
                return this.lastName + ' ' + this.firstName
            },
            set: function(value){
                var names = value.split(' ');
                this.firstName = names[0],
                this.lastName = names[names.length - 1]
            }
        }
    }
}
</script>

