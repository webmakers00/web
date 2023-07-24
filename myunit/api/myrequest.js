export default{
	a:1,
	c:"99",
	par:{
		urlbef:"http://192.168.101.1/api",
		data:{},				
		Header:{
			"content-type":"application/json",
			"content-type":"application/x-www-form-urlencoded"
		},
		"method":"GET",
		"dataType":"json"		
	},
	req(op={}){
		op.url=this.par.urlbef+op.url;
		op.data=op.data || this.par.data;
		op.Header=op.Header || this.par.Header;
		op.method=op.method || this.par.method;
		op.dataType=op.dataType || this.par.dataType;
		return new Promis((res,rej)=>{
			uni.request({
				...op,
				success: (rer) => {
				 if(rer.statusCode!==200){	return rej();  }	//404
				 let d = rer.data.data;
				 res(data)
				}
			})
			
		}
		)
	}
}


uni.request({
    url: 'https://www.example.com/request', //仅为示例，并非真实接口地址。
    data: {
        text: 'uni.request'
    },
    header: {
        'custom-header': 'hello' //自定义请求头信息
    },
    success: (res) => {
        console.log(res.data);
        this.text = 'request success';
    }
});
