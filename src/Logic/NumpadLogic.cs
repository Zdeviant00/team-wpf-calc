namespace TeamWpfCalc.Logic
{
    public class NumpadLogic
    {
        private string _currentInput = "";

        public void InputNumber(string digit)
        {
            _currentInput += digit;
        }

        public void AddDecimal()
        {
            if (!_currentInput.Contains("."))
                _currentInput += ".";
        }

        public string GetInput() => _currentInput;
        public void Clear() => _currentInput = "";
    }
}