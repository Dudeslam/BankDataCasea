import { createRouter, createWebHistory } from 'vue-router'
import Home from './pages/Home.vue'
import Accounts from './pages/Accounts.vue'
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
