import { createWebHistory, createRouter } from "vue-router";
import Home from "@/components/Home.vue";
import Counter from "@/components/Counter.vue";
import FetchData from "@/components/FetchData.vue";
import ActivityCard from "@/components/ActivityCard.vue";

//Create routes
const routes = [
    {
        path: "/",
        name: "Home",
        component: Home,
    },
    {
        path: "/Counter",
        name: "Counter",
        component: Counter,
    },
    {
        path: "/FetchData",
        name: "FetchData",
        component: FetchData,
    },
    {
        path: "/ActivityCard",
        name: "ActivityCard",
        component: ActivityCard,
    }
];

//Create router from routes
const router = createRouter({
    history: createWebHistory(),
    routes,
});

export default router;