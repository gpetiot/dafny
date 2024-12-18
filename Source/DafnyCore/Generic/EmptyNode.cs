using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Dafny;

public class EmptyNode : Node {
  public override RangeToken RangeToken { get; set; } = new(new Token(), new Token());
  public override IOrigin Tok => new Token();
  public override IEnumerable<INode> Children => Enumerable.Empty<Node>();
  public override IEnumerable<INode> PreResolveChildren => Enumerable.Empty<Node>();
}