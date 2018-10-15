using System;
using System.Collections.Generic;
using System.Text;

namespace DataFeed.Test
{
	public class TestFixture
	{
		public static string JsonStr
		{
			get
			{
				return
					@"{
					'RawData': {
						'Markets': [
							{
								'Id': 'NbSeMfzhDCHT_HdtAYZF_7zjFkI',
								'Selections': [
									{
										'Id': 'b0Ut0-KyBdfknmjckAQHY1sxs3U',
										'Price': 4.2,
										'Tags': {
											'participant': '1',
											'name': 'Coronel'
										}
									},
									{
										'Id': '222GQLldt5t2lZCW93EgdBMwDIbPzzz',
										'Price': 12,
										'Tags': {
											'participant': '2',
											'name': 'Advancing'
										}
									},
									{
										'Id': '333GQLldt5t2lW93EgdBMwDIbPyyy',
										'Price':2.2,
										'Tags': {
											'participant': '3',
											'name': 'Curlins Honor'
										}
									},
									{
										'Id': '444GQLldt5t2lW93EgdBMwDIbPxxx',
										'Price':1.89,
										'Tags': {
											'participant': '4',
											'name': 'Lookin To Strike'
										}
									},
									{
										'Id': '555GQLldt5t2lW93EgdBMwDIbPwww',
										'Price':3.2,
										'Tags': {
											'participant': '5',
											'name': 'Mr Ritz'
										}
									},
									{
										'Id': '666GQLldt5t2lW93EgdBMwDIbPvvv',
										'Price':8.65,
										'Tags': {
											'participant': '6',
											'name': 'Strike Me Down'
										}
									},
									{
										'Id': '777GQLldt5t2lW93EgdBMwDIbPuuu',
										'Price':6.54,
										'Tags': {
											'participant': '7',
											'name': 'Flight Deck'
										}
									},
									{
										'Id': '888GQLldt5t2lW93EgdBMwDIbPttt',
										'Price':7.65,
										'Tags': {
											'participant': '8',
											'name': 'My Mandara'
										}
									},
									{
										'Id': '999GQLldt5t2lW93EgdBMwDIbPsss',
										'Price':5.43,
										'Tags': {
											'participant': '9',
											'name': 'Peppered'
										}
									}
								]
							}
					    ]
					}
				}";
			}	//end of get
		}	//end JsonStr

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
