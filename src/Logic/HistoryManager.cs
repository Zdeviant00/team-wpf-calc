using System.Collections.Generic;

namespace TeamWpfCalc.Logic
{
    public class HistoryManager
    {
        private readonly List<string> _history = new();

        public void AddRecord(string operation)
        {
            _history.Add(operation);
        }

        public IReadOnlyList<string> GetHistory() => _history.AsReadOnly();
        
        public void Clear() => _history.Clear();
        
        public string RemoveLast()
        {
            if (_history.Count == 0) return "";
            string last = _history[_history.Count - 1];
            _history.RemoveAt(_history.Count - 1);
            return last;
        }
    }
}