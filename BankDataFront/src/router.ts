import { createRouter, createWebHistory } from 'vue-router'
import Home from './components/Home.vue'
import Accounts from './components/Accounts.vue'
import Transactions from './components/Transactions.vue'


const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: '',
      component: Home
    },
    {
      path: '/Accounts',
      name: '',
      component: Accounts
    },
  ]
})

export default router
