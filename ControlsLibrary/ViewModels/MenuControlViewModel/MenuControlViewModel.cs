﻿using System.Collections.Generic;
using Diary.Commons;
using Diary.Commons.Mediator;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using System.Linq;

namespace Diary.Controls.ViewModels.MenuControlViewModel
{
    public class MenuControlViewModel : ViewModel, IColleague, IMenuControlViewModel
    {
        public IMediator ConcreteMediator { get; }
        public ObservableCollection<TreeViewItem> TreeItems { get; set; }

        public MenuControlViewModel(IMediator mediator)
        {
            mediator.Colleague2 = this;
            ConcreteMediator = mediator;
            TreeItems = new ObservableCollection<TreeViewItem>
            {
                new TreeViewItem()
                    {
                        Header = "Развлечения",
                        ItemsSource = new List<TreeViewItem>
                        {
                            new TreeViewItem(){ Header = "Фаст-фуд" },
                            new TreeViewItem(){ Header = "Кино" },
                            new TreeViewItem(){ Header = "Аттракционы" },
                        }
                    },
                new TreeViewItem()
                    {
                        Header = "Продукты",
                        ItemsSource = new List<TreeViewItem>
                        {
                            new TreeViewItem(){ Header = "Продукты для дома" },
                            new TreeViewItem(){ Header = "Вкусняшки" },
                        }
                    },
                new TreeViewItem()
                    {
                        Header = "Одежда",
                        ItemsSource = new List<TreeViewItem>
                        {
                            new TreeViewItem(){ Header = "Одежда для детей" },
                            new TreeViewItem(){ Header = "Одежда для себя" },
                            new TreeViewItem(){ Header = "Одежда для попугая" },
                        }
                    }
            };
        }

        public RelayCommand AddCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    Send(new NotifyInformation(ActionTypes.EditCategory, new[] { 0 }));
                });
            }
        }

        public RelayCommand RemoveCommand
        {
            get
            {
                return new RelayCommand(obj =>
                TreeItems.Remove(TreeItems.Last()),
                (_) => TreeItems.Count > 0);
            }
        }

        public void Notify(NotifyInformation information)
        {

        }

        public void Send(NotifyInformation information)
        {
            ConcreteMediator.Send(information, this);
        }
    }
}
