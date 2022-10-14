using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
namespace 攒机助手专业版 
{
    interface IUndoRedo
    {
        void Undo(int level);
        void Redo(int level);
        void SetStateForUndoRedo();
    }
    public class Canvas
    {
        public DataTable Children = new DataTable();
    }
    public class Memento
    {
        private DataTable _ContainerState;
        public DataTable ContainerState
        {
            get { return _ContainerState; }
        }
        public Memento(DataTable containerState)
        {
            this._ContainerState = containerState;
        }
    }
    public class MementoOriginator
    {
        private Canvas _Container;
        public MementoOriginator(Canvas container)
        {
            _Container = container;
        }
        public Memento getMemento()
        {
            DataTable _ContainerState = new DataTable();
            DataTable newItem = DeepClone(_Container.Children);
            _ContainerState = newItem;
            return new Memento(_ContainerState);
        }
        public void setMemento(Memento memento)
        {
            Memento memento1 = MementoClone(memento);
            _Container.Children = memento1.ContainerState;
        }

        public Memento MementoClone(Memento memento)
        {
            DataTable _ContainerState = new DataTable();
            DataTable newItem = DeepClone(memento.ContainerState);
            _ContainerState = newItem;
            return new Memento(_ContainerState);
        }
        private DataTable DeepClone(DataTable element)//深度拷贝
        {
            List<string[]> data = new List<string[]>();
            for (int i = 0; i < element.Rows.Count; i++)
            {
                int cellCount = element.Columns.Count;
                string[] rowData = new string[cellCount];
                for (int j = 0; j < cellCount; j++)
                {
                    rowData[j] = (string)element.Rows[i][j];
                }
                data.Add(rowData);
            }
            List<string[]> newdata;
            using (var ms = new MemoryStream())//序列化
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, data);
                ms.Position = 0;
                newdata = (List<string[]>)formatter.Deserialize(ms);
            }
            #region xml序列化
            //string shapestring = XamlWriter.Save(data);
            //StringReader stringReader = new StringReader(shapestring);
            //XmlTextReader xmlTextReader = new XmlTextReader(stringReader);
            //List<string[]> newdata = (List<string[]>)XamlReader.Load(xmlTextReader);
            #endregion
            DataTable pDT = new DataTable();
            for (int i = 0; i < element.Columns.Count; i++)
            {
                pDT.Columns.Add(element.Columns[i].ColumnName);
            }
            for (int i = 0; i < newdata.Count; i++)
            {
                pDT.Rows.Add(newdata[i]);
            }
            return pDT;
        }
    }
    class Caretaker
    {
        private Stack<Memento> UndoStack = new Stack<Memento>();
        private Stack<Memento> RedoStack = new Stack<Memento>();
        public Memento getUndoMemento()
        {
            if (UndoStack.Count >= 2)
            {
                RedoStack.Push(UndoStack.Pop());
                return UndoStack.Peek();
            }
            else
                return null;
        }
        public Memento getRedoMemento()
        {
            if (RedoStack.Count != 0)
            {
                Memento m = RedoStack.Pop();
                UndoStack.Push(m);
                return m;
            }
            else
                return null;
        }
        public void InsertMementoForUndoRedo(Memento memento)
        {
            if (memento != null)
            {
                UndoStack.Push(memento);
                RedoStack.Clear();
            }
        }
        public bool IsUndoPossible()
        {
            if (UndoStack.Count >= 2)
            {
                return true;
            }
            else
                return false;

        }
        public bool IsRedoPossible()
        {
            if (RedoStack.Count != 0)
            {
                return true;
            }
            else
                return false;
        }
    }
    public class UndoRedo : IUndoRedo
    {
        Caretaker _Caretaker = new Caretaker();
        MementoOriginator _MementoOriginator = null;
        public event EventHandler EnableDisableUndoRedoFeature;
        public UndoRedo(Canvas container)
        {
            _MementoOriginator = new MementoOriginator(container);
        }
        public void Undo(int level)
        {
            Memento memento = null;
            for (int i = 1; i <= level; i++)
            {
                memento = _Caretaker.getUndoMemento();
            }
            if (memento != null)
            {
                _MementoOriginator.setMemento(memento);
            }
            if (EnableDisableUndoRedoFeature != null)
            {
                EnableDisableUndoRedoFeature(null, null);
            }
        }
        public void Redo(int level)
        {
            Memento memento = null;
            for (int i = 1; i <= level; i++)
            {
                memento = _Caretaker.getRedoMemento();
            }
            if (memento != null)
            {
                _MementoOriginator.setMemento(memento);

            }
            if (EnableDisableUndoRedoFeature != null)
            {
                EnableDisableUndoRedoFeature(null, null);
            }
        }
        public void SetStateForUndoRedo()
        {
            Memento memento = _MementoOriginator.getMemento();
            _Caretaker.InsertMementoForUndoRedo(memento);
            if (EnableDisableUndoRedoFeature != null)
            {
                EnableDisableUndoRedoFeature(null, null);
            }
        }
        public bool IsUndoPossible()
        {
            return _Caretaker.IsUndoPossible();
        }
        public bool IsRedoPossible()
        {
            return _Caretaker.IsRedoPossible();
        }
    }
}