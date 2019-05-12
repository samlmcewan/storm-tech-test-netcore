using System.Collections.Generic;
using System.ComponentModel;
using Todo.Models.TodoItems;

namespace Todo.Models.TodoLists
{
    public class TodoListDetailViewmodel
    {
        public int TodoListId { get; }
        public string Title { get; }
        public ICollection<TodoItemSummaryViewmodel> Items { get; }
        public bool HideDone { get; }

        public TodoListDetailViewmodel(int todoListId, string title, ICollection<TodoItemSummaryViewmodel> items, bool hideDone)
        {
            Items = items;
            TodoListId = todoListId;
            Title = title;
            HideDone = hideDone;
        }

        public TodoListDetailViewmodel(int todoListId, string title, List<TodoItemSummaryViewmodel> items)
        {
            TodoListId = todoListId;
            Title = title;
            Items = items;
        }
    }
}