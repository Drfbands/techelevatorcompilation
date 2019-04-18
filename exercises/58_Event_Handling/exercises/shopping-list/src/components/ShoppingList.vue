
<template>
<div class="shopping-list">
    <ul>
  <li v-for="item in items" v-bind:key="item.id" v-bind:class="{'completed' : item.completed}" v-on:click="changeStatus(item.id)" v-on:mouseover="changeHighlight(item.id)">
   <input type="checkbox"> {{ item.item }} <i class="far fa-check-circle" v-bind:class="{ completed: item.completed }"></i>
  </li>
</ul>
  </div>
</template>

<script>

export default {
name: "shopping-list",
  data(){
        return {
          items: [
  { id: 1, item: 'Steaks', completed: false },
  { id: 2, item: 'Burgers', completed: false },
  { id: 3, item: 'Fish', completed: false },
  { id: 4, item: 'Peanuts', completed: false },
  { id: 5, item: 'Bread', completed: false },
  { id: 6, item: 'Milk', completed: false },
  { id: 7, item: 'Cheerios', completed: false },
  { id: 8, item: 'Carrots', completed: false },
  { id: 9, item: 'Slim Jims', completed: false },
  { id: 10, item: 'Chicken', completed: false }
    ]
        }
        }
        ,
        methods: {
  changeStatus(id) {
    const arrIndex = this.items.findIndex((item) => item.id == id);
    this.items[arrIndex].completed = !this.items[arrIndex].completed;
}
}

}

</script>

<style>
.shopping-list {
    width:450px;
    background: #fff;
    margin: 50px auto;
    font-family: 'Roboto Condensed', sans-serif;
    border-radius: 10px;
}
h1 {
    background:#f2f2f2;
    color:#5c8578;
    padding:10px;
    font-size:24px;
    text-transform: uppercase;
    text-align: center;
    margin-bottom: 0px;
    border-top-left-radius: 10px;
    border-top-right-radius: 10px;
}
ul {
    list-style-type: none;
    margin:0px;
    padding:0px;
}
li {
    font-size: 24px;
    border-bottom:1px solid #f2f2f2;
    padding:10px 20px;
}
li:last-child{
    border:0px;
}
li.completed {
    text-decoration: line-through;
    color:darkgrey;
}

li.hover {
    color:darkgrey;
}

i.far.fa-check-circle { 
    float:right;
    color: darkgray;
}

i.far.fa-check-circle.completed {
    color:green;
}
</style>