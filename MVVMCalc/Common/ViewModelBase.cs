namespace MVVMCalc.Common
{
    using System.ComponentModel;

    /// <summary>
    /// viewModelお基本クラス。INotifyPropertyChangedの実装を提供します。
    /// </summary>
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged(string propertyName)
        {
            var h = this.PropertyChanged;
            if (h != null)
            {
                h(this,new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}