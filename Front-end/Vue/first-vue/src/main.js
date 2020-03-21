import Vue from 'vue'
import upperFirst from 'lodash/upperFirst'
import camelCase from 'lodash/camelCase'
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
4
// var app4 = new Vue(
//   {
//     el: '#condtionalRending',
//     render: h => h(appD)
//   })

const requireComponent = require.context(
  // 其组件目录的相对路径
  './components',
  // 是否查询其子目录
  false,
  // 匹配基础组件文件名的正则表达式
  /Base[A-Z]\w+\.(vue|js)$/
)

requireComponent.keys().forEach(fileName => {
  // 获取组件配置
  const componentConfig = requireComponent(fileName)

  // 获取组件的 PascalCase 命名
  const componentName = upperFirst(
    camelCase(
      // 获取和目录深度无关的文件名
      fileName
        .split('/')
        .pop()
        .replace(/\.\w+$/, '')
    )
  )

  // 全局注册组件
  Vue.component(
    componentName,
    // 如果这个组件选项是通过 `export default` 导出的，
    // 那么就会优先使用 `.default`，
    // 否则回退到使用模块的根。
    componentConfig.default || componentConfig
  )
})
