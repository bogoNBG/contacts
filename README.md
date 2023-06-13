 public static int IdNum(List<string> lines)
        {
            if (lines.Count > 0)
            {
                string lastLine = lines[lines.Count - 1];
                int lastIndex = Convert.ToInt32(lastLine.Split(',')[0]);

                if (lastIndex >= lines.Count)
                {
                    for (int i = 1; i <= lines.Count; i++)
                    {
                        string line = lines[i - 1];
                        int lineId = Convert.ToInt32(line.Split(',')[0]);
                        if (lineId != i)
                        {
                            return i;
                        }                       
                    }
                }
                else
                {
                    return lines.Count + 1;
                }
            }
            else return 1;
            return -1;
        }
