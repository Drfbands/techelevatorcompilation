
<template>
<div class="shopping-list">
    <h1>My Shopping List</h1>
    <ul>
  <li v-for="item in items" v-bind:key="item.id" v-bind:class="{'completed' : item.completed}">
    {{ item.message }} 
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
  { id: 1, message: 'Tuna', completed: true },
  { id: 2, message: 'Grape', completed: false },
  { id: 3, message: 'Banana', completed: false },
  { id: 4, message: 'Strawberry', completed: false },
  { id: 5, message: 'Brawnie', completed: true },
  { id: 6, message: 'Ice Cream', completed: false },
  { id: 7, message: 'Pepsi', completed: false },
  { id: 8, message: 'Pizza', completed: true },
  { id: 9, message: 'Chips', completed: false },
  { id: 10, message: 'Lettace', completed: false }
    ]
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
</style>