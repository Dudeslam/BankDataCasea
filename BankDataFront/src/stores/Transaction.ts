import { defineStore } from "pinia";
import { instance } from '../network/network.ts'

export interface Transaction {
    ProviderId: number;
    ReceiverId: number;
    TransactionId: number;
    TransferSum: number;
    DateTime: number;
}

export const useTransactionStore = defineStore({
    id: "Transaction",
    state: (): Transaction => ({
        ProviderId: 0,
        ReceiverId: 0,
        TransactionId: 0,
        TransferSum: 0,
        DateTime: Date.now(),
    }),
    actions: {
        
    }
})