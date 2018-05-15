using System.ComponentModel;

namespace XliffTranslatorTool.Parser
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public class TranslationUnit : INotifyPropertyChanged
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    {
        public string Identifier { get; set; }
        public string Meaning { get; set; }
        public string Description { get; set; }
        public string Source { get; set; }
        private string _target;
        public string Target { get => _target; set { _target = value; OnPropertyChanged("Target"); } }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string prop)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }

        public override bool Equals(object obj)
        {
            TranslationUnit other = (obj as TranslationUnit);
            return (other != null) && (other.Identifier == this.Identifier);
        }
    }
}
