using UnityEngine;
using VRC.SDK3.Data;

public static class TableText
{
    public static string Create(DataList dataList)
    {
        var rowHeaderWidth = 0;
        var columnWidth = 0;
        
        for (int i = 0, n = dataList.Count; i < n; i++)
        {
            var rowList = dataList[i].DataList;
            for (int j = 0, m = rowList.Count; j < m; j++)
            {
                if (j == 0)
                {
                    rowHeaderWidth = Mathf.Max(rowHeaderWidth, rowList[j].String.Length);
                }
                else
                {
                    columnWidth = Mathf.Max(columnWidth, rowList[j].String.Length);
                }
            }
        }
        
        
        return Create(dataList, rowHeaderWidth + 2, columnWidth + 2);
    }

    public static string Create( DataList dataList, int rowHeaderWidth, int columnWidth )
    {
        var sb = new System.Text.StringBuilder();
        
        for (int i = 0, n = dataList.Count; i < n; i++)
        {
            var content = dataList[i].DataList;
            
            if (i == 0)
            {
                SetHeader(sb, content, rowHeaderWidth, columnWidth);
            }
            else
            {
                sb.AppendLine();
                SetRow(sb, content, rowHeaderWidth, columnWidth);
            }
        }
        
        return sb.ToString();
    }
    
    private static void SetHeader(System.Text.StringBuilder sb, DataList list, int rowHeaderWidth, int columnWidth)
    {
        var listCount = list.Count;
        
        // ヘッダー
        sb.Append( '|' );
        for (int i = 0; i < listCount; i++)
        {
            if (i == 0)
            {
                sb.Append( $" {list[i].String}".PadRight(rowHeaderWidth, ' ') );
            }
            else
            {
                sb.Append( $" {list[i].String}".PadRight(columnWidth, ' ') );
            }
            sb.Append( '|' );
        }
        
        sb.AppendLine();
        // セパレート
        sb.Append( '|' );
        for (int i = 0; i < listCount; i++)
        {
            if (i == 0)
            {
                sb.Append( $" ".PadLeft(rowHeaderWidth, '-') );
            }
            else
            {
                sb.Append( $":".PadLeft(columnWidth, '-') );
            }
            sb.Append( '|' );
        }

    }
    
    private static void SetRow(System.Text.StringBuilder sb, DataList list, int rowHeaderWidth, int columnWidth)
    {
        var listCount = list.Count;
        
        sb.Append( '|' );
        for (int i = 0; i < listCount; i++)
        {
            if (i == 0)
            {
                sb.Append( $" {list[i].String}".PadRight(rowHeaderWidth, ' ') );
            }
            else
            {
                sb.Append( $"{list[i].String} ".PadLeft(columnWidth, ' ') );
            }
            sb.Append( '|' );
        }
    }
}
