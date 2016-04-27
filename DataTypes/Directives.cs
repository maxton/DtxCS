namespace DtxCS.DataTypes
{
  public abstract class DataDirective : DataNode
  {
    public override string Name { get; }
    public override string ToString() => Name + " " + constant;
    public override DataType Type { get; }

    public override DataNode Evaluate() => this;

    private string constant;

    internal DataDirective(string name, DataType type, string constant)
    {
      this.Name = name;
      this.Type = type;
      this.constant = constant;
    }
  }

  public class DataIfDef : DataDirective
  {
    public DataIfDef(string constant) : base("#ifdef", DataType.IFDEF, constant) { }
  }
  public class DataDefine : DataDirective
  {
    public DataDefine(string constant) : base("#define", DataType.DEFINE, constant) { }
  }
  public class DataIfNDef : DataDirective
  {
    public DataIfNDef(string constant) : base("#ifndef", DataType.IFNDEF, constant) { }
  }
  public class DataInclude : DataDirective
  {
    public DataInclude(string constant) : base("#include", DataType.INCLUDE, constant) { }
  }
  public class DataMerge : DataDirective
  {
    public DataMerge(string constant) : base("#merge", DataType.MERGE, constant) { }
  }
  public class DataElse : DataDirective
  {
    public DataElse() : base("#else", DataType.ELSE, "") { }
  }
  public class DataEndIf : DataDirective
  {
    public DataEndIf() : base("#endif", DataType.ENDIF, "") { }
  }
}
