import TodoList from '@/components/TodoList';
/* eslint-disable-next-line no-unused-vars */
import { shallowMount, Wrapper } from '@vue/test-utils';

import chai from 'chai';
chai.should();

describe('TodoList', () => {

    /** @type Wrapper */
    let wrapper;

    beforeEach( () => {
        wrapper = shallowMount(TodoList);
    });

    it('should be a Vue instance', () => {
        wrapper.isVueInstance().should.be.true;
    });

    it('renders a single task list item to the unordered list', () => {
        const todos = [ {id: 1, task: "Drive to work", completed: false} ];
        wrapper.setData({todos});
        wrapper.find('.todo-list ul li').text().should.equal('Drive to work');
    });
<<<<<<< HEAD
=======

>>>>>>> 2e9c975d68116d20a7820a90b1ba5fe3ddd6c6de
    it('renders 3 todo list items to the DOM when our todos array contains 3 objects', () => {
        const todos = [
            { id: 1, task: 'Wake up', completed: false },
            { id: 2, task: '5 Minute Morning Movement', completed: false },
            { id: 3, task: 'Meditate', completed: false }
        ];
        wrapper.setData({todos});
        wrapper.findAll('li').length.should.equal(3);
    })

    it('clicking the list item should call change status and set completed to true',() => {
        const todos = [ {id: 1, task: "Drive to work", completed: false} ];
        wrapper.setData({todos});
        wrapper.find('.todo-list ul li').trigger('click');
<<<<<<< HEAD
        chai.assert.equal(todos[0].completed, true);
    });
    it('with a task completed the list item should contain the todo-completed class', () => {
        const todos = [ {id: 1, task: "Drive to work", completed: true} ];
        wrapper.setData({todos});
        wrapper.find('.todo-list ul li').hasClass('todo-completed').should.be.true;
    });
});



=======
        // the next two lines are different ways to test the same thing.
        // chai.assert.equal(todos[0].completed, true);
        wrapper.vm.todos[0].completed.should.be.true;
    });

    it('with a task completed the list item should contain the todo-completed class', () => {
        const todos = [ {id: 1, task: "Drive to work", completed: true} ];
        wrapper.setData({todos});
        // hasClass is deprecated, please, for the love of Pete, use .classes
        // wrapper.find('.todo-list ul li').hasClass('todo-completed').should.be.true;
        wrapper.find('.todo-list ul li').classes('todo-completed').should.be.true;
    });
});
>>>>>>> 2e9c975d68116d20a7820a90b1ba5fe3ddd6c6de
