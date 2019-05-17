import Vue from 'vue'
import App from './App.vue'
import appA from './components/Bind.vue'
import appB from './components/ComputeAtrribute.vue'
import appC from './components/ClassStyleBind.vue'
import appD from './components/ConditionalRending.vue'
import appE from './components/ListRending.vue'
import appF from './components/EventHandling.vue'
import appG from './components/FormInputBinding.vue'
import apph from './components/ParentComponents.vue'
// import appi from './components/ButtonCounter.vue'

var app5 = new Vue(
    {
      el: '#componentDiv',
      render: h => h(apph)
    })

// var app5 = new Vue(
//     {
//       el: '#eventHandling',
//       render: h => h(appF)
//     })
// var app4 = new Vue(
//   {
//     el: '#listRending',
//     render: h => h(appE)
//   })

// var app = new Vue(
//   {
//   el: '#app',
//   render: h => h(App)
// }
// )
// var app2 = new Vue(
//   {
//     el: '#appA' ,
//     render: h => h(appA)
//   }
// )

// var app3 = new Vue(
//   {
//     el: '#example' ,
//     render: h => h(appB)
//   }
// )

// var app4 = new Vue(
//   {
//     el: '#classStyleExample',
//     render: h => h(appC)
//   })

// var app4 = new Vue(
//   {
//     el: '#condtionalRending',
//     render: h => h(appD)
//   })
