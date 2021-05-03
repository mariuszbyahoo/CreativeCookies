import { Card, CardContent, Typography, Divider } from "@material-ui/core";
import { makeStyles } from "@material-ui/core/styles";
import React from "react";

var posts = [
  { title: "Google.com", link: "http://google.com", content: "blablabla" },
  { title: "Wp.pl", link: "http://wp.pl", content: "blablabla" },
  { title: "onet.pl", link: "http://onet.pl", content: "blablabla" },
  { title: "kwejk.pl", link: "http://kwejk.pl", content: "blablabla" },
  {
    title: "404",
    link: "http://848949848948948%*^&%*&%^&%^4565845.pl",
    content: "blablabla",
  },
];

const useStyles = makeStyles((theme) => ({
  root: {
    flexGrow: 1,
  },
  menuButton: {
    marginRight: theme.spacing(2),
  },
  title: {
    flexGrow: 1,
  },
}));

export default function PostList({ posts }) {
  const classes = useStyles();
  return posts.map((post) => (
    <Card className={classes.container}>
      <CardContent>
        <Typography color='textPrimary' className={classes.title}>
          {post.title}
        </Typography>
        <Typography color='textSecondary'>{post.link}</Typography>
        <Divider />
        <Typography variant='body2' component='p'>
          {post.content}
        </Typography>
      </CardContent>
    </Card>
  ));
}
