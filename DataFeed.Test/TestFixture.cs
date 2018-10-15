using System;
using System.Collections.Generic;
using System.Text;

namespace DataFeed.Test
{
	public class TestFixture
	{
		public static string XmlStr
		{
			get { return @"
				<meeting>
				  <races>
				    <race number='1' name='Evergreen Turf Plate' id='1536514' Status='OPEN'>
				      <horses>
				        <horse name='Coronel'>
				          <number>1</number>
				        </horse>
				        <horse name='Advancing'>
				          <number>2</number>
				        </horse>
				        <horse name='Curlins Honor' >
				          <number>3</number>
				        </horse>
				        <horse name='Lookin To Strike'>
				          <number>4</number>
				        </horse>
				        <horse name='Mr Ritz'>
				          <number>5</number>
				        </horse>
				        <horse name='Strike Me Down'>
				            <number>6</number>
				          </horse>
				        <horse name='Flight Deck'>
				          <number>7</number>
				        </horse>
				        <horse name='My Mandara'>
				          <number>8</number>
				        </horse>
				        <horse name='Peppered'>
				            <number>9</number>
				          </horse>
				      </horses>
				      <prices>
				        <price>
				          <horses>
				            <horse number='1' Price='4.2'/>
				            <horse number='2' Price='12'/>
				            <horse number='3' Price='2.2'/>
				            <horse number='4' Price='1.89'/>
				            <horse number='5' Price='3.2'/>
				            <horse number='6' Price='8.65'/>
				            <horse number='7' Price='6.54'/>
				            <horse number='8' Price='7.65'/>
				            <horse number='9' Price='5.43'/>
				          </horses>
				        </price>
				      </prices>
				    </race>
				  </races>
				</meeting>
				"; }	//end of get
		}
	}	//end class

}
