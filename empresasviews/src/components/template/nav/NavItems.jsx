import React from 'react'

export default props=>
<a href={`#/${props.rout}`} className={`fa fa-${props.icone}`}><span className="font-nav ml-1">{props.titulo}</span></a>