import Vue from 'vue'
import App from './App.vue'
import appA from './components/Bind.vue'

var app = new Vue(
  {
  el: '#app',
  render: h => h(App)
}
)
var app2 = new Vue(
  {
    el: '#appA' ,
    render: h => h(appA)
  }
)