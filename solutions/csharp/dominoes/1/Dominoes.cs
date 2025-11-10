using System;
using System.Collections.Generic;
using System.Linq;

public static class Dominoes
{
    public static bool CanChain(IEnumerable<(int, int)> dominoes)
    {
        var list = dominoes.ToList();
        if (!list.Any()) return true;

        bool Backtrack(List<(int, int)> remaining, List<(int, int)> chain)
        {
            if (!remaining.Any())
            {
                return chain.First().Item1 == chain.Last().Item2;
            }

            for (int i = 0; i < remaining.Count; i++)
            {
                var domino = remaining[i];
                remaining.RemoveAt(i);

                foreach (var d in new[] { domino, (domino.Item2, domino.Item1) })
                {
                    if (!chain.Any() || chain.Last().Item2 == d.Item1)
                    {
                        chain.Add(d);
                        if (Backtrack(remaining, chain)) return true;
                        chain.RemoveAt(chain.Count - 1);
                    }
                }

                remaining.Insert(i, domino);
            }

            return false;
        }

        return Backtrack(list, new List<(int, int)>());
    }
}
