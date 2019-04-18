import TodoList from '@/components/ShoppingList';
/* eslint-disable-next-line no-unused-vars */
import { shallowMount, Wrapper } from '@vue/test-utils';

import chai from 'chai';
chai.should();

describe('ShoppingList', () => {

    /** @type Wrapper */
    let wrapper;

    beforeEach( () => {
        wrapper = shallowMount(TodoList);
    });

    it('should be a instance of vue', () => {
        wrapper.isVueInstance().should.be.true;
    });

    it('render a item to the DOM and the name should be what we expect', () => {
        const testDOM = [ {id: 10, name: "Rice", completed: false} ];
        wrapper.setData({ groceries: testDOM});
        wrapper.find('.shopping-list ul li').text().should.equal('Rice');
    });

    it('renders 5 items to the DOM and the number of elements should be 5', () => {
        const testGroceryList = [ 
            {id: 10, name: "Rice", completed: false},
            {id: 11, name: "Green Beans", completed: false},
            {id: 12, name: "Squash", completed: false},
            {id: 13, name: "Peanuts", completed: false},
            {id: 14, name: "Cranberries", completed: false},
    ];
        wrapper.setData({ groceries: testGroceryList});
        wrapper.findAll('li').length.should.equal(5);
    });

    it('renders an item where completed is false and it should NOT have the class completed', () => {
        const testCompleted = [ {id: 10, name: "Rice", completed: false} ];
        wrapper.setData({ groceries: testCompleted});
        wrapper.find('.shopping-list ul li').classes('completed').should.be.false;
    });

    it('clicking list item should call change status and add class completed', () => {
        const testClicks = [ {id: 10, name: "Rice", completed: false} ];
        wrapper.setData({ groceries: testClicks});
        wrapper.find('li').trigger('click');
        wrapper.vm.groceries[0].completed.should.be.true;
    });

});
