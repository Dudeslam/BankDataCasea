<script setup lang="ts">
import { instance } from '../network/network';
import { onMounted } from 'vue';

// var ListOfAcc = Ref();

async function getAccounts(){
    await instance.get("/Accounts").then((resp) => {
        let accounts = resp.data;
        console.log(accounts)
    })
}

onMounted(()=>{
    getAccounts();
})
</script>

<template>
    <div class="flex border-2 border-black mx-10">
        <div class="">

        </div>
        <h1 class="">Filler stuff</h1>
    </div>
</template>

<style scoped lang="scss">

</style>