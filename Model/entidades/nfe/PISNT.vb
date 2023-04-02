﻿''' <summary>
''' TAG do grupo de PIS não tributado
''' CST = 04, 05, 06, 07, 08 ou 09
''' </summary>
Public Class PISNT
    ''' <summary>
    ''' 04 - Operação Tributável (tributação monofásica (alíquota zero));
    ''' 05 - Operação Tributável (Substituição Tributária);
    ''' 06 - Operação Tributável (alíquota zero);
    ''' 07 - Operação Isenta da Contribuição;
    ''' 08 - Operação Sem Incidência da Contribuição;
    ''' 09 - Operação com Suspensão da Contribuição;
    ''' </summary>
    Public Property CST() As String
End Class