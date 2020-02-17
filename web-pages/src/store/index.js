import Vue from 'vue'
import Vuex from 'vuex'
import git from './modules/git'
import training from './modules/training'
import node from './modules/node'
import registry from './modules/registry'
import dataSet from './modules/dataSet'
import registrySelector from './modules/registrySelector'
import gitSelector from './modules/gitSelector'
import environmentVariables from './modules/environmentVariables'
import cluster from './modules/cluster'

Vue.use(Vuex)
export default new Vuex.Store({
  modules: {
    dataSet,
    registrySelector,
    gitSelector,
    training,
    git,
    node,
    registry,
    environmentVariables,
    cluster,
  },
  state: {
    // ログイン情報
    loginName: '',
    loginTenant: '',
    // 画面ブロック（ローディング）情報
    loading: true,
    loadingCnt: 0,
  },
  getters: {
    getLoginTenant: state => () => state.loginTenant,
    getLoadingCnt: state => () => state.loadingCnt,
    getLoading: state => () => state.loading,
  },
  mutations: {
    setLoading(state, loading) {
      state.loading = loading
    },
    incrementLoading(state) {
      state.loadingCnt++
    },
    decrementLoading(state) {
      state.loadingCnt--
    },
    setLogin(state, { name, tenant }) {
      state.loginName = name
      state.loginTenant = tenant
    },
  },
  actions: {
    incrementLoading(context) {
      context.commit('incrementLoading')
    },
    decrementLoading(context) {
      setTimeout(() => {
        context.commit('decrementLoading')
      }, 300) // delay 300ms
    },
  },
})
