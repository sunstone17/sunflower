<template>
    <div>
        <h1>
            Form input binding
        </h1>
        <input v-model="message" placeholder="Edit me"/>
        <p> message is {{message}} </p>

        <span>Multiline message is:</span>
        <p style="white-space: pre-line;">{{textarea}}</p>
        <br />
        <textarea v-model="textarea" placeholder="add multiple lines"></textarea>

        <div>
            <input type="checkbox" id="checkbox" v-model="checked"/>
            <label for='checkbox'>{{ checked }}</label>
        </div>
            <input type="checkbox" id='jack' value='jack' v-model="checkedNames">
            <label for='jack'>jack</label>
            <input type="checkbox" id='john' value='john' v-model="checkedNames">
            <label for='john'>john</label>
            <input type="checkbox" id='mike' value='mike' v-model="checkedNames">
            <label for='mike'>mike</label>

            <input type="checkbox" id='hhh' value='hhh' v-model="checkedNames">
            <label for='checkbox'>hhh</label>
            <br>
            <span>CheckNames: {{checkedNames}}</span>
        <div>

        <div>
            <input type="radio" id="one" value="One" v-model="picked">
            <label for="one">One</label>
            <br>
            <input type="radio" id="two" value="Two" v-model="picked">
            <label for="two">Two</label>
            <br>
            <span>Picked: {{ picked }}</span>

        </div>

        </div>
        <div>
            <select v-model="selected" aria-placeholder="请选择">
                <option disabled value="">请选择</option>
                <option>A</option>
                <option>B</option>
                <option>C</option>
                <option>D</option>
            </select>
            <span>selected: {{selected}}</span>
        </div>

          <div>
            <select v-model="selectedMulti" multiple style="width: 50px;">
                <option disabled value="">请选择</option>
                <option>A</option>
                <option>B</option>
                <option>C</option>
                <option>D</option>
            </select>
            <span>selected multi: {{selectedMulti}}</span>
        </div>

        <input type="radio" v-model="pick2" :value="a"/>
        <span>{{pick2}}</span>
        <button @click="change"> change </button>

        <input type="text" v-model.trim="msg" placeholder="trim"/>
        <span>msg: {{msg}}</span>

    </div>
</template>

<script>
export default {

    data(){
        return {
            name: 'formInputBinding',
            message:'123',
            textarea:'123',
            checked: true,
            checkedNames:[],
            picked:'',
            selected:[],
            selectedMulti:[],
            a:true,
            pick2:false,
            msg:''
        }
    },
    methods:{
        change:function(){
            this.a = !this.a
            alert(this.pick2 === this.a)
        }
    }
}
</script>

