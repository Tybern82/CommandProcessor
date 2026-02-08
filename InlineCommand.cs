using System;
using System.Collections.Generic;
using System.Text;

namespace com.tybern.CMDProcessor {
    public class InlineCommand : Command {

        public InlineCommand(Action action, Command.RunThread Type = Command.RunThread.Background) {
            this.Type = Type;
            this.commandAction = action;
        }

        public Command.RunThread Type { get; }
        private Action commandAction;

        public void Process() => commandAction.Invoke();
    }
}
