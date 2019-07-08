using BatPrismTutorial.Model;
using BatPrismTutorial.Services;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BatPrismTutorial.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {       /* 
        * public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
        }
        */
        private IBatFamilyService BatItemService { get; }

        private IEnumerable<BatFamily> BatFamilyAll;

        public IEnumerable<BatFamily> BatFamilyAlls
        {
            get { return this.BatFamilyAll; }
            set { this.SetProperty(ref this.BatFamilyAll, value); }
        }

        private string inputText;

        public string InputText
        {
            get { return this.inputText; }
            set { this.SetProperty(ref this.inputText, value); }
        }

        public DelegateCommand AddCommand { get; }

        public DelegateCommand<BatFamily> DeleteCommand { get; }


        public MainPageViewModel(INavigationService navigationService,IBatFamilyService BatSericeParam)
            :base(navigationService)
        {
            this.BatItemService = BatSericeParam;

            this.AddCommand = new DelegateCommand(this.AddTodoItem, () => !string.IsNullOrEmpty(this.InputText))
                .ObservesProperty(() => this.InputText);

            this.DeleteCommand = new DelegateCommand<BatFamily>(this.DeleteTodoItem);
        }
        //    


        /*  private void DeleteTodoItem(BatFamily BatParent)
          {
              this.BatItemService.Delete(BatParent.Id);
              this.BatFamilyAlls = this.BatItemService.GetAll();
          }*/
        private async void DeleteTodoItem(BatFamily todoItem)
        {
            await this.BatItemService.DeleteAsync(todoItem);
            this.BatFamilyAlls = await this.BatItemService.GetAllAsync();
        }


        /*  private void AddTodoItem()
          {
              this.BatItemService.Insert(new BatFamily { Nombre = this.InputText });
              this.InputText = "";
              this.BatFamilyAlls = this.BatItemService.GetAll();
          }*/
        private async void AddTodoItem()
        {
            await this.BatItemService.InsertAsync(new BatFamily { Nombre = this.InputText });
            this.InputText = "";
            this.BatFamilyAlls = await this.BatItemService.GetAllAsync();
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        /*public void OnNavigatedTo(NavigationParameters parameters)
        {
            this.BatFamilyAlls = this.BatItemService.GetAll();
        }*/
        public async void OnNavigatedTo(NavigationParameters parameters)
        {
            this.BatFamilyAlls = await this.BatItemService.GetAllAsync();
        }




    }
}
