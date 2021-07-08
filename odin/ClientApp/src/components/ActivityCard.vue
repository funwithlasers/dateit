<template>
    <h1>Your Activities</h1>

    <ul id="activity-card-list" class="no-bullets">
        <li v-for="activitycard in activitycards" v-bind:key="activitycard">
            <div class="test-border">
                {{ activitycard.category }} <p /> {{ activitycard.description }} <p /> {{ activitycard.duration }} <p /> {{ activitycard.location }} <p />
            </div>
        </li>
    </ul>



    <button v-on:click="deleteFields">Delete Fields</button>

</template>


<script lang="ts">
    export default {
        name: "ActivityCard",
        data() {
            return {
                activitycards: []
            }
        },
        methods: {
            getActivityCards() {
               fetch('/activitycard')
                    .then(response => response.json())
                    .then(data => this.activitycards = data);
            },
        },
        mounted() {
            this.getActivityCards();
        }
       
    }
</script>

<style>
    ul.no-bullets {
        list-style-type: none;
        margin: 0;
        padding: 0;
    }    
    div.test-border {
        border-style: solid;
        border-width: 1px;
    }
    li{
        display: inline-grid;
    }
</style>
